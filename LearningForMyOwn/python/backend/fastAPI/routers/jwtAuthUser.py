from fastapi import APIRouter, Depends, HTTPException
from pydantic import BaseModel
from fastapi.security import OAuth2PasswordBearer, OAuth2PasswordRequestForm
from jose import jwt, JWTError
from passlib.context import CryptContext
from datetime import datetime, timedelta

ALGORITHM = "HS256"
ACCES_TOKEN_DURATION = 1
SECRET = "63616e746765747468697332776f726b"

router = APIRouter()
oauth2 = OAuth2PasswordBearer(tokenUrl="login")

crypt = CryptContext(schemes=["bcrypt"])

# Router
class User(BaseModel):
    username:str
    fullname:str
    email:str
    disabled:bool

class UserDB(User):
    password:str

users_db = {
    "Leo":{
        "username":"Leo",
        "fullname":"Leo Coves",
        "email":"l.coves@gmail.com",
        "disabled":False,
        "password": "$2a$12$s2X4x/aC.yDocbigbyAXFOLSsPIfOKKEgePyqWCaazAzQGYHA5uLS"
    },
    "Alex":{
        "username":"Alex",
        "fullname":"Alex Martinez",
        "email":"alexxx@gmail.com",
        "disabled":True,
        "password": "$2a$12$18woSzDwJ9xKihk3BSxXwujiCm8nx0zDiMb6Z7Cs7iAMVLYXPJxPW"
    }
}

def search_user(username:str):
    if username in users_db:
        return UserDB(**users_db[username])
    
async def auth_user(token:str = Depends(oauth2)):
    exception = HTTPException(
            status_code=400, detail="Credenciales invalidas")
    
    try:
        username = jwt.decode(token, SECRET, algorithms=[ALGORITHM]).get("sub")
        if username is None:
            raise exception

    except JWTError:
        raise exception
    
    return search_user(username)
    
async def current_user(user:User = Depends(auth_user)):
    if user.disabled:
        raise HTTPException(
            status_code=400, detail="Usuario inactivo")
    
    return user


@router.post("/login")
async def login(form: OAuth2PasswordRequestForm = Depends()):
    user_db = users_db.get(form.username)
    if not user_db:
        raise HTTPException(
            status_code=400, detail="El usuario no es correcto")
    

    user = search_user(form.username)
    if not crypt.verify(form.password, user.password):
        raise HTTPException(
            status_code=400, detail="La contraseña no es correcta")
    
    acces_token_expiration = timedelta(minutes=ACCES_TOKEN_DURATION)

    access_token = {"sub":user.username,
                    "exp":datetime.utcnow() + timedelta(minutes=ACCES_TOKEN_DURATION)
                    }

    return {"access_token": jwt.encode(access_token, SECRET, algorithm=ALGORITHM), "token_type": "bearer"}



@router.get("/users/me")
async def me(user:User = Depends(current_user)):
    return user
    
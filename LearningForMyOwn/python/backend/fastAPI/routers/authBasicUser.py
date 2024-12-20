from fastapi import FastAPI, Depends, HTTPException
from pydantic import BaseModel
from fastapi.security import OAuth2PasswordBearer, OAuth2PasswordRequestForm
from routers import users


app = FastAPI()
oauth2 = OAuth2PasswordBearer(tokenUrl="login")

# Router
app.include_router(users.router)

class User(BaseModel):
    username:str
    fullname:str
    email:str
    disabled:str

class UserDB(User):
    password:str

users_db = {
    "leo":{
        "username":"Leo",
       " fullname":"Leo Coves",
        "email":"l.coves@gmail.com",
        "disabled":True,
        "password": "123456"
    },
    "alex":{
        "username":"Alex",
       " fullname":"Alex Martinez",
        "email":"alexxx@gmail.com",
        "disabled":True,
        "password": "654321"
    }
}

def search_user(username:str):
    if username in users_db:
        return UserDB(**users_db[username])
    
def current_user(token:str = Depends(oauth2)):
    user = search_user(token)
    if not user:
        raise HTTPException(
            status_code=400, detail="Credenciales invalidas")
    return user

@app.post("/login")
async def login(form:OAuth2PasswordRequestForm = Depends()):
    user_db = users_db.get(form.username)
    
    if user_db:
        raise HTTPException(
            status_code=400, detail="El usuario no es correcto")
    
    user = search_user(form.surname)
    if not form.password == user.password:
        raise HTTPException(
            status_code=400, detail="La contraseña no es correcta")
    
    return {"access_token": user.username, "token_type": "bearer"}

@app.get("/users/me")
async def me(user:User = Depends(current_user)):
    return user
    
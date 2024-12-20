from fastapi import APIRouter, HTTPException, status
from db.models.user import User
from db.client import db_client
from db.schemas.user import user_schema, users_schema
from bson import ObjectId

router = APIRouter(prefix="/userdb",
                   tags=["userdb"],
                   responses={404:{"message":"No encontrado"}})

## Entidad User


usersList = []


# Operaciones GET

@router.get("/")
async def users():
    return users_schema(db_client.users.find())

# Path
@router.get("/{id}")
async def user(id: str):
    return searchUser("_id", ObjectId(id))
    
# Query
@router.get("/")
async def user(id: str):
    return searchUser("_id", ObjectId(id)) 



# POST// Crear

@router.post("/", response_model=User, status_code=status.HTTP_201_CREATED)
async def user(user: User):
    if type(searchUser("email", user.email)) == User:
        raise HTTPException(status_code=404, detail="Ya existe")

    user_dict = dict(user)
    del user_dict["id"]

    id = db_client.users.insert_one(user_dict).inserted_id
    new_user = user_schema(db_client.users.find_one({"_id": id}))
    return User(**new_user)

## Enviar un user nuevo por thunder client con post

## PUT// Editar
@router.put("/")
async def user(user: User):

    user_dict = dict(user)
    del user_dict["id"]

    try:
        db_client.users.find_one_and_replace({"_id": ObjectId(user.id)}, user_dict)
    except:
        return {"error":"No se ha encontrado"}
    

# DELETE // Eliminar

@router.delete("/{id}")
async def user(id: str, status_code=status.HTTP_204_NO_CONTENT):
    found = db_client.users.find_one_and_delete({"_id": ObjectId(id)})

    if not found:
        return {"Error:": "No se ha eliminado ningun registro"}

def searchUser(field: str, key):
    try:
       user = db_client.users.find_one({field: key})
       return User(**user_schema(user))
    except:
        return {"Error": "no se ha encontrado el usuario"}
    

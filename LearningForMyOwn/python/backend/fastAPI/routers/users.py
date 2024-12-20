from fastapi import APIRouter
from pydantic import BaseModel

router = APIRouter()

## Entidad User

class User(BaseModel):
    id: int
    name: str
    surname: str
    url: str
    age: int


usersList = [User(id=1, name="Leo", surname="Coves", url="https://mouredev.com", age=19),
            User(id=2, name="Alex", surname="Martinez", url="https://mouredev.com", age=19),
            User(id=3, name="Juan", surname="Gutierrez", url="https://mouredev.com", age=19)]


# @app.get("/usersjson")
# async def usersjson():
#     return [{"name":"Leo", "surname":"Coves", "url":"https://mouredev.com", "age":19},
#             {"name":"Alex", "surname":"Martinez", "url":"https://alex.com", "age":23},
#             {"name":"Juan", "surname":"Gutierrez", "url":"https://instagram.com","age":18}]

# Operaciones GET

@router.get("/users")
async def users():
    return usersList

# Path
@router.get("/user/{id}")
async def user(id: int):
    users = filter(lambda user: user.id == id, usersList)
    try:
        return list(users)[0]
    except:
        return {"error": "No se ha encontrado el user"}
    
# Query
@router.get("/userquery/")
async def user(id: int):
    return search_user(id) 


def search_user(id : int):
    users = filter(lambda user: user.id == id, usersList)
    try:
        return list(users)[0]
    except:
        return {"error": "No se ha encontrado el user"}
    

# POST// Crear

@router.post("/user/")
async def user(user: User):
    if(type(search_user(user.id)) == User):
        return {"error":"Ya existe"}
    else:
        usersList.append(user)
        return user

## Enviar un user nuevo por thunder client con post

## PUT// Editar
@router.put("/user/")
async def user(user: User):
    found = False

    for index, saved_user in enumerate(usersList):
        if (saved_user.id == user.id):
            usersList[index] = user
            found = True
            return user

    if not found:
        return {"error":"No se ha encontrado"}
    

# DELETE // Eliminar

@router.delete("/user/{id}")
async def user(id: int):
    found = False

    for index, del_user in enumerate(usersList):
        if(del_user.id == id):
            del usersList[index]
            found = True
            return {"message":"Eliminado correctamente"}
    
    if not found:
        return {"error" : "No existe"}

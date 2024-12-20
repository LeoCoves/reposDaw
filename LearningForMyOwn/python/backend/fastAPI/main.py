from fastapi import FastAPI
from routers import products, users, jwtAuthUser, usersDb

app = FastAPI()

# Router
app.include_router(products.router)
app.include_router(users.router)
app.include_router(jwtAuthUser.router)
app.include_router(usersDb.router)

@app.get("/")
async def root():
    return ("Hola Mundo")

@app.get("/url")
async def url():
    return { "url_curso":"https://mouredev.com/python" }


# Iniciar el server con py -m uvicorn main:app --reload
# Detener el server con Ctrl C 

# Documentacion con Swagger /docs
# Documentacion con Redocly /redoc
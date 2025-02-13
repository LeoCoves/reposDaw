
let form = document.querySelector("form");
let btnEnviar = form.querySelector("button");

btnEnviar.addEventListener("click", function(){
    let name = form.user.value;
    let API_URL = `https://api.github.com/users/${name}`;

    let promise = fetch(API_URL);

    promise.then(res => res.json()
    ).then((data)=>{
        console.log(data);

        let h1 = document.createElement("h1");
        h1.textContent = data.login;
        let img = document.createElement("img");
        img.src = data.avatar_url;

        document.body.appendChild(h1);
        document.body.appendChild(img);
    }).catch(error => console.log("Error"))
})
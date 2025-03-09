import React from "react"
import { TwitterFollowCard } from "./components/TwitterFollowCard.jsx"

export function App (){

    //Otra manera de pasar las props
    const users = [
        {
            id:1,
            name:"Leo",
            username:"leocovess",
            imgSrc:"https://unavatar.io/twitch/midudev",
            initialIsFollowing:true
        },
        {
            id: 2,
            name:"Leo",
            username:"leocovess",
            imgSrc:"https://unavatar.io/twitch/midudev",
            initialIsFollowing:false
        },
        {
            id:3,
            name:"Leo",
            username:"leocovess",
            imgSrc:"https://unavatar.io/x/kikobeats",
            initialIsFollowing:false
        },
        {
            id:4,
            name:"Leo",
            username:"leocovess",
            imgSrc:"https://unavatar.io/twitch/midudev",
            initialIsFollowing:false
        },
        {
            id:5,
            name:"Leo",
            username:"leocovess",
            imgSrc:"https://unavatar.io/twitch/midudev",
            initialIsFollowing:true
        },
        {
            id:6,
            name:"Leo",
            username:"leocovess",
            imgSrc:"https://unavatar.io/x/kikobeats",
            initialIsFollowing:false
        },
        {
            id:7,
            name:"Leo",
            username:"leocovess",
            imgSrc:"https://unavatar.io/twitch/midudev",
            initialIsFollowing:false
        },
        {
            id:8,
            name:"Leo",
            username:"leocovess",
            imgSrc:"https://unavatar.io/x/kikobeats",
            initialIsFollowing:true
        }
    ]



    return (
        <>
            <h1>Users</h1>
            {
                users.map(user => {
                    const {name, username, imgSrc, initialIsFollowing} = user
                    return (
                        <TwitterFollowCard 
                            key={user.id}
                            name={name} 
                            username={username} 
                            imgSrc={imgSrc} 
                            initialIsFollowing={initialIsFollowing}
                        />
                    )
                })
            }
        </>
    )
}
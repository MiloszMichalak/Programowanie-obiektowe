package com.api

import io.ktor.http.HttpStatusCode
import io.ktor.server.application.Application
import io.ktor.server.request.receive
import io.ktor.server.response.respond
import io.ktor.server.routing.get
import io.ktor.server.routing.post
import io.ktor.server.routing.route
import io.ktor.server.routing.routing

fun Application.configureRouting(){
    routing{
        route("/tickets"){
            val ticketService = TicketService()
            
            post("/add"){
                val ticket = call.receive<ExposedTicket>()
                val id = ticketService.create(ticket)
                call.respond(HttpStatusCode.Created, id)
            }
            
            get("/list"){
                call.respond(HttpStatusCode.OK, ticketService.readAll())
            }
        }
    }
}
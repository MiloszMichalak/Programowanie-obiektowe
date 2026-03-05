package com.api

import kotlinx.coroutines.Dispatchers
import kotlinx.serialization.Serializable
import org.jetbrains.exposed.sql.*
import org.jetbrains.exposed.sql.transactions.experimental.newSuspendedTransaction
import org.jetbrains.exposed.sql.transactions.transaction

@Serializable
data class ExposedTicket(
    val passengerName: String, 
    val departure: String,
    val destination: String,
    val departureTime: String,
    val seatNumber: Int,
    val trainNumber: String,
)

class TicketService() {
    object Tickets : Table() {
        val id = integer(name = "id").autoIncrement()
        val passengerName = varchar("passenger_name", 50)
        val destination = varchar("destination", 50)
        val departure = varchar("departure", 50)
        val departureTime = varchar("departure_time", 50)
        val seatNumber = integer("seat_number")
        val trainNumber = varchar("train_number", 50)

        override val primaryKey = PrimaryKey(id)
    }

    init {
        transaction {
            SchemaUtils.create(Tickets)
        }
    }

    suspend fun create(user: ExposedTicket): Int = dbQuery {
        Tickets.insert {
            it[passengerName] = user.passengerName
            it[destination] = user.destination
            it[departure] = user.departure
            it[departureTime] = user.departureTime
            it[seatNumber] = user.seatNumber
            it[trainNumber] = user.trainNumber
        }[Tickets.id]
    }

    suspend fun readAll(): List<ExposedTicket> {
        return dbQuery {
            Tickets.selectAll()
                .map { ExposedTicket(
                    passengerName = it[Tickets.passengerName], 
                    destination = it[Tickets.destination],
                    departure = it[Tickets.departure],
                    departureTime = it[Tickets.departureTime],
                    seatNumber = it[Tickets.seatNumber],
                    trainNumber = it[Tickets.trainNumber]
                ) 
            }
        }
    }

    private suspend fun <T> dbQuery(block: suspend () -> T): T =
        newSuspendedTransaction(Dispatchers.IO) { block() }
}


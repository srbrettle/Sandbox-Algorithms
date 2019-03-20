"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/demoHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (sum) {
    var li = document.createElement("li");
    li.textContent = sum;
    document.getElementById("messagesList").appendChild(li);
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var intA = document.getElementById("inputIntA").value;
    var intB = document.getElementById("inputIntB").value;
    var intC = document.getElementById("inputIntC").value;
    connection.invoke("Adder", intA, intB, intC).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
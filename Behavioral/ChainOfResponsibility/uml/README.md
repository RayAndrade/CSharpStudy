**Behavioral Pattern — Chain of Responsibility** for **C# students**, 

# 🌟 Chain of Responsibility — Participants (for C# Students)

## **Handler**

* Declares the method for handling requests.
* Stores a reference to the next Handler.
* Forwards requests when unable to handle.

## **ConcreteHandler**

* Handles requests within its responsibility range.
* Decides whether to process or pass forward.
* Sends unhandled requests to successor.

## **Client**

* Sends request to the first Handler.
* Does not know which Handler will process it.
* Relies on the chain to manage requests.


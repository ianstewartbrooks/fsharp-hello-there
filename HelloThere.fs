open System

let sayHello firstname surname =
    // Say hello using the user's first and surname

    printfn "Hello there, %s %s!" firstname surname
    
let getName() = 
    // Ask the user to enter first and surname

    printf "Enter your first name: "

    let firstname = Console.ReadLine()

    printf "now your surname: "
    let surname = Console.ReadLine()

    sayHello firstname surname

[<EntryPoint>]
let main argv =    

    // call get name function
    getName()

    // Don't close window until user hits a key
    printfn "\n\nPress a key to finish."
    Console.ReadKey() |> ignore

    0 // return an integer exit code


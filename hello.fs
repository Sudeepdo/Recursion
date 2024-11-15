day1
1st question 
// let square x = x*x
// let cube x = x*x*x
// let sign x = 
//            if x>0 then "positive"
//            else if x<0 then "negative"
//            else "zero"

// let passfive f =  (f 5)
// printfn "%A" (passfive square)
// printfn "%A" (passfive cube)
// printfn "%A" (passfive sign)

2nd question

// let double = fun x -> x *2
// let x = double 5
// printfn "%A" x

3rdquestion

// let curriedAdd x y = x+y
// printfn "%A"(curriedAdd 5 10)
// let toupledAdd (x,y) =  x+y
// printfn "%A"(toupledAdd (10,5))

4th question 
// let Someting x y =
// let doublex = x*2
// let doubley = y*2
// let value = Someting 5 6
// printfn "%A" value

5th question
// let print x = 
//     printfn "%s" x
// "Hello my name is Sudeep" |> print





// let rec recursion n =
//     if n <= 1 then
//         n
//     else
//         n + recursion (n - 1)
 
// let x = recursion 10
// printfn "%A" x



// open System
// let rec factorial x =
//     if x<1 then 1
//      else 
//         x* factorial(x-1)
// let res = factorial(6)

// printfn "%A" res




// let NumberAry = [|1;2;3;4|]
 
// printfn "%A" NumberAry
 
// printfn "%A" NumberAry.[2]
 
// let newArray = Array.append NumberAry [|11;12;13|]
 
// printfn "%A" NumberAry
 
// printfn "%A" newArray
 
// let newArray2 = NumberAry |> Array.append [|11;12;13|]
 
// printfn "%A" NumberAry
 
// printfn "%A" newArray2

Day4

// let x = fun n -> n*n
// let square = [2;3;4;5] |> List.map x
 
// printfn "%A" square
 
// let f = fun (s : string) -> s.Length
// let newList = ["five"; "six"; "pick up"; "sticks"]
// let lengths = newList |> List.map f
// printfn "%A" lengths


2
// let something = [4;5;6;7]
// let z = something |> List.iter (printfn "%A")



// let something = [4;5;6;7]
// let z = something |> List.iter (printfn "%A")                 / collection of list depending on the providing list 

// let newList = something |> List.collect (fun x ->[1..x])
// printfn "%A" newList





let x = ["do"; "mi"; "sol"]
 
let illJoined = x |> List.fold (fun acc y -> acc + "-" + y) "hi"
 
printfn "%s" illJoined













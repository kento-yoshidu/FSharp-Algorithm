// 


let f x =
    x * x + 2 * x + 3

let fn t =
    f(f(f t + t) + f(f t))

printfn "%i" (fn 0)
//=> 1371

printfn "%i" (fn 3)
//=> 722502

printfn "%i" (fn 10)
//=> 1111355571

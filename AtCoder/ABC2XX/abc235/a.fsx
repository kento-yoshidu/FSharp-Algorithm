// 

let fn s =
    s
    |> Seq.map(fun c->
        let d = int c - int '0'
        d * 111)
    |> Seq.sum

printfn "%i" (fn "123")
//=> 666

printfn "%i" (fn "999")
//=> 2997

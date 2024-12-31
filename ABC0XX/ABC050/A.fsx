// https://atcoder.jp/contests/abc050/tasks/abc050_a

let run a op b =
    match op with
    | "+" -> a + b
    | "-" -> a - b
    | _ -> failwith "error"

printfn "%i" (run 1 "+" 2)
//=> 3

printfn "%i" (run 5 "-" 7)
//=> -2

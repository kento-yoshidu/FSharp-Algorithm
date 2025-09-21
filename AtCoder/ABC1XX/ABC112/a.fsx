// https://atcoder.jp/contests/abc112/tasks/abc112_a

let fn (n: int) (ab: int list option) : string =
    if n = 1 then
        "Hello World"
    else
        ab |> Option.get |> List.sum |> string

printfn "%s" (fn 1 None)
//=> Hello World

printfn "%s" (fn 2 (Some [3; 5]))
//=> 8

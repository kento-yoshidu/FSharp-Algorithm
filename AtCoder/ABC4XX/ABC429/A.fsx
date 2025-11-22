// https://atcoder.jp/contests/abc429/tasks/abc429_a

let fn n m =
    [ 0 .. n-1]
    |> List.map (fun i ->
        if i <= m-1 then
            "OK"
        else
            "Too Many Requests"
        )

printfn "%A" (fn 5 3)
//=> ["OK"; "OK"; "OK"; "Too Many Requests"; "Too Many Requests"]

printfn "%A" (fn 3 5)
//=> ["OK"; "OK"; "OK"]

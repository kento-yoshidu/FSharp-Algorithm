// https://atcoder.jp/contests/abc022/tasks/abc022_a

let run _ s t w a =
    let cum =
        a
        |> List.scan (fun acc x -> acc + x) w

    cum
    |> List.filter (fun x -> s <= x && x <= t)
    |> List.length

printfn "%i" (run 5 60 70 50 [10; 10; 10; 10])
//=> 2

printfn "%i" (run 5 50 100 120 [-10; -20; -30; 70])
//=> 2

// https://atcoder.jp/contests/abc146/tasks/abc146_a

let fn s =
    let days = [| "SUN"; "MON"; "TUE"; "WED"; "THU"; "FRI"; "SAT" |]

    days
    |> Array.rev
    |> Array.findIndex (fun day -> day = s)
    |> fun i -> i + 1

printfn "%i" (fn "SAT")
//=> 1

printf "%i" (fn "SUN")
//=> 7

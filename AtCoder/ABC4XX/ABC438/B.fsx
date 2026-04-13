// https://atcoder.jp/contests/abc438/tasks/abc438_b

let fn n m (s: string) (t: string) =
    let digit (c: char) = int c - int '0'

    [0 .. n - m]
    |> List.map(fun i ->
        [0 .. m - 1]
        |> List.sumBy (fun j ->
            let x = digit s[i + j]
            let y = digit t[j]

            (x - y + 10) % 10))
    |> List.min

printfn "%i" (fn 4 2 "2025" "91")
//=> 2

printfn "%i" (fn 3 2 "438" "38")
//=> 0

printfn "%i" (fn 5 5 "00000" "11111")
//=> 45

printfn "%i" (fn 8 3 "20251227" "438")
//=> 13

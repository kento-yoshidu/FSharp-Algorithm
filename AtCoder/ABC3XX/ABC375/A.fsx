// https://atcoder.jp/contests/abc375/tasks/abc375_a

let fn _n s =
    s
    |> Seq.windowed 3
    |> Seq.filter (fun arr ->
        arr = [| '#'; '.'; '#' |])
    |> Seq.length

printfn "%i" (fn 6 "#.##.#")
//=> 2

printfn "%i" (fn 1 "#")
//=> 0

printfn "%i" (fn 9 "##.#.#.##")
//=> 3

// https://atcoder.jp/contests/abc011/tasks/abc011_1

let run n =
    match n with
    | 12 -> 1
    | _ -> n + 1

printfn "%i" (run 1)
//=> 2

printfn "%i" (run 12)
//=> 1

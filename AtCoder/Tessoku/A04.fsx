// https://atcoder.jp/contests/tessoku-book/tasks/tessoku_book_d

let fn n =
    [9 .. -1 .. 0]
    |> List.map (fun i -> ((n >>> i) &&& 1).ToString())
    |> String.concat ""

printfn "%s" (fn 13)
//=> 0000001101

printfn "%s" (fn 37)
//=> 0000100101

printfn "%s" (fn 1000)
//=> 1111101000

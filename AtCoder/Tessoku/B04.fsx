// https://atcoder.jp/contests/tessoku-book/tasks/tessoku_book_cc

let fn (s: string) =
    s.ToCharArray()
    |> Array.rev
    |> Array.mapi (fun i c -> if c = '1' then pown 2 i else 0)
    |> Array.sum

printfn "%i" (fn "1101")
//=> 13

printfn "%i" (fn "1")
//=> 1

printfn "%i" (fn "100101")
//=> 37

printfn "%i" (fn "10000000")
//=> 128

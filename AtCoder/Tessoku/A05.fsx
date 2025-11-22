// https://atcoder.jp/contests/tessoku-book/tasks/tessoku_book_e

let fn n k =
    seq {
        for i in 1..n do
            for j in 1..n do
                let x = k - i - j

                if 1 <= x && x <= n then
                    yield 1 }
    |> Seq.length

printfn "%i" (fn 3 6)
//=> 7

printfn "%i" (fn 3000 4000)
//=> 6498498

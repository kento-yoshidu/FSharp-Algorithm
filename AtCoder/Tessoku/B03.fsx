// https://atcoder.jp/contests/tessoku-book/tasks/tessoku_book_cb

let fn n (a: int array) =
    let isExists =
        seq {
            for i in 0 .. n-1 do
                for j in i+1 .. n-1 do
                    for k in j+1 .. n-1 do
                        yield a.[i] + a.[j] + a.[k]
        }
        |> Seq.exists ((=) 1000)

    if isExists then "Yes" else "No"

printfn "%s" (fn 5 [| 100; 250; 350; 400; 600 |])
//=> Yes

printfn "%s" (fn 10 [| 50; 150; 250; 350; 450; 550; 650; 750; 850; 950 |])
//=> No

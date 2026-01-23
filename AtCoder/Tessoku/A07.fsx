// https://atcoder.jp/contests/tessoku-book/tasks/tessoku_book_g

let fn d n (lr: (int * int) array) =
    let imos = Array.zeroCreate<int> (d + 1)

    for l, r in lr.[0..n-1] do
        imos.[l - 1] <- imos.[l - 1] + 1
        imos.[r]     <- imos.[r]     - 1

    let ans = Array.zeroCreate<int> d

    let mutable s = 0

    for i in 0 .. d - 1 do
        s <- s + imos.[i]
        ans.[i] <- s

    ans

printfn "%A" (fn 8 5 [| 2, 3; 3, 6; 5, 7; 3, 7; 1, 5 |])
//=> [| 1; 2; 4; 3; 4; 3; 2; 0 |]

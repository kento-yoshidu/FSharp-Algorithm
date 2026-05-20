// https://atcoder.jp/contests/abc441/tasks/abc441_c

let fn n k x a =
    let sorted = a |> Array.sort

    let startIndex = sorted.Length - (n - k)
    let startAns = n - k

    let prefixSum =
        sorted
        |> Array.take startIndex
        |> Array.sum

    if prefixSum < x then
        -1
    else
        let rec loop index (sum: int64) ans =
            if sum >= x then
                ans
            else
                loop
                    (index - 1)
                    (sum + sorted[index - 1])
                    (ans + 1)

        loop startIndex 0L startAns

printfn "%i" (fn 3 2 5L [| 10; 6; 8 |])
//=> 2

printfn "%i" (fn 2 1 8L [| 6; 10 |])
//=> -1

printfn "%i" (fn 5 3 3000000000L [| 1000000000; 1000000000; 1000000000; 1000000000; 1000000000 |])
//=> 5

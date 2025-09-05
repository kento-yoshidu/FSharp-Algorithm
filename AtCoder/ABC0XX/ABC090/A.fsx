// https://atcoder.jp/contests/abc090/tasks/abc090_a

let fn (c1: string) (c2: string) (c3: string) =
    let ch1 = c1.[0]
    let ch2 = c2.[1]
    let ch3 = c3.[2]

    System.String([| ch1; ch2; ch3 |])

printfn "%s" (fn "ant" "obe" "rec")
//=> abc

printfn "%s" (fn "edu" "cat" "ion")
//=> ean

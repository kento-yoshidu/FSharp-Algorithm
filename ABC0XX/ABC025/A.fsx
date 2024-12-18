// https://atcoder.jp/contests/abc025/tasks/abc025_a

let run (s: string) n =
    let c1 = (n-1) / 5
    let c2 = (n-1) % 5

    string s.[c1] + string s.[c2]

printfn "%s" (run "abcde" 8)
//=> bc

printfn "%s" (run "aeiou" 22)
//=> ue

printfn "%s" (run "vwxyz" 25)
//=> zz

// https://atcoder.jp/contests/abc236/tasks/abc236_a

let fn (s: string) a b =
    let chars = s.ToCharArray()
    let tmp = chars.[a-1]
    chars.[a-1] <- chars.[b-1]
    chars.[b-1] <- tmp
    System.String chars

printfn "%s" (fn "chokudai" 3 5)
//=> chukodai

printfn "%s" (fn "aa" 1 2)
//=> aa

printfn "%s" (fn "aaaabbbb" 1 8)
//=> baaabbba

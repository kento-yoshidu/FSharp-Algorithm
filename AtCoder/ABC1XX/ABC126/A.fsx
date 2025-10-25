// https://atcoder.jp/contests/abc126/tasks/abc126_a

let fn n k (s: string) =
    let chars = s.ToCharArray()
    chars.[k-1] <- System.Char.ToLower(chars.[k-1])
    new string(chars)

printfn "%s" (fn 3 1 "ABC")
//=> aBC

printfn "%s" (fn 4 3 "CABA")
//=> CAbA

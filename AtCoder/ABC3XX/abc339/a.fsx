// https://atcoder.jp/contests/abc339/tasks/abc339_a

let fn (s: string) =
    s.Split('.') |> Array.last

printfn "%s" (fn "atcoder.jp")
//=> jp

printfn "%s" (fn "translate.google.com")
//=> com

printfn "%s" (fn ".z")
//=> z

printfn "%s" (fn "..........txt")
//=> txt

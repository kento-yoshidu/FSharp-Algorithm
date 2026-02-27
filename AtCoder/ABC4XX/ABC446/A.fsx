// https://atcoder.jp/contests/abc446/tasks/abc446_a

let fn (s: string) =
    "Of" + s.ToLower()

printfn "%s" (fn "Glen")
//=> Ofglen

printfn "%s" (fn "I")
//=> Ofi

printfn "%s" (fn "Fred")
//=> Offred

// https://atcoder.jp/contests/abc179/tasks/abc179_a

let fn (s: string) =
    if s.[s.Length - 1] = 's' then
        s + "es"
    else
        s + "s"

printfn "%s" (fn "apple")
//=> apples

printfn "%s" (fn "bus")
//=> buses

printfn "%s" (fn "box")
//=> boxs

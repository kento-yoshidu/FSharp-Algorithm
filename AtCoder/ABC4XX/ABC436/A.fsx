// https://atcoder.jp/contests/abc436/tasks/abc436_a

let fn n (s: string) =
    s.PadLeft(n, 'o')

printfn "%s" (fn 5 "abc")
//=> ooabc

printfn "%s" (fn 2 "o")
//=> oo

printfn "%s" (fn 12 "vgxgpuam")
//=> oooovgxgpuam

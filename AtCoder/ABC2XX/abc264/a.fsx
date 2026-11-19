// https://atcoder.jp/contests/abc264/tasks/abc264_a

let fn l r =
    "atcoder".Substring(l-1, r - l + 1)

printfn "%s" (fn 3 6)
//=> code

printfn "%s" (fn 4 4)
//=> o

printfn "%s" (fn 1 7)
//=> atcoder

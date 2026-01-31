// https://atcoder.jp/contests/abc173/tasks/abc173_a

let fn n =
    let c = (n + 999) / 1000

    c*1000 - n

printfn "%i" (fn 1900)

printfn "%i" (fn 3000)

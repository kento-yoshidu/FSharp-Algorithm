// https://atcoder.jp/contests/abc249/tasks/abc249_a

let fn a b c d e f x =
    let calc run speed rest x =
        let q = x / (run + rest);
        run * speed * q + min run (x - (run + rest) * q) * speed

    let t = calc a b c x
    let a = calc d e f x

    if t = a then
        "Draw"
    elif t > a then
        "Takahashi"
    else
        "Aoki"

printfn "%s" (fn 4 3 3 6 2 5 10)
//=> Takahashi

printfn "%s" (fn 3 1 4 1 5 9 2)
//=> Aoki

printfn "%s" (fn 1 1 1 1 1 1 1)
//=> Draw

// https://atcoder.jp/contests/abc239/tasks/abc239_a

let fn (h: float) =
    sqrt (h * (float 12_800_000 + h))

printfn "%f" (fn 333)
//=> 65287.907678

printfn "%f" (fn 634)
//=> 90086.635835

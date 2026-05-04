// https://atcoder.jp/contests/abc398/tasks/abc398_a

let fn n =
    if n % 2 = 1 then
        String.replicate (n/2) "-" + "=" + String.replicate (n/2) "-"
    else
        String.replicate (n / 2 - 1) "-" + "==" + String.replicate (n / 2 - 1) "-"

printfn "%s" (fn 4)
//=> -==-

printfn "%s" (fn 7)
//=> ---=---

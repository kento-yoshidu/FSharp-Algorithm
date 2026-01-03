// https://atcoder.jp/contests/abc401/tasks/abc401_a

let fn s =
    if 200 <= s && s <= 299 then
        "Success"
    else
        "Failure"

printfn "%s" (fn 200)
//=> Success

printfn "%s" (fn 401)
//=> Failure

printfn "%s" (fn 999)
//=> Failure

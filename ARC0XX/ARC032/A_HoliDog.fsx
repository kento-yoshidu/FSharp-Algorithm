// https://atcoder.jp/contests/arc032/tasks/arc032_1

let run n =
    if n = 1 then
        "BOWWOW"
    else
        let sum = n*(n+1) / 2

        if Seq.exists (fun i -> sum % i = 0) (seq { 2 .. sum - 1 }) then
            "BOWWOW"
        else
            "WANWAN"

printfn "%s" (run 2)
//=> WANWAN

printfn "%s" (run 5)
//=> BOWWOW

printfn "%s" (run 1)
//=> BOWWOW

printfn "%s" (run 999)
//=> BOWWOW

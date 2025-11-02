// https://atcoder.jp/contests/abc160/tasks/abc160_a

let fn (s: string) =
    if s.[2] = s.[3] && s.[4] = s.[5] then
        "Yes"
    else
        "No"

printfn "%s" (fn "sippuu")
//=> Yes

printfn "%s" (fn "iphone")
//=> No

printfn "%s" (fn "coffee")
//=> Yes

// https://atcoder.jp/contests/abc358/tasks/abc358_a

let fn s t =
    if s = "AtCoder" && t = "Land" then
        "Yes"
    else
        "No"

printfn "%s" (fn "AtCoder" "Land")
//=> Yes

printfn "%s" (fn "CodeQUEEN" "Land")
//=> No

printfn "%s" (fn "aTcodeR" "lANd")
//=> No

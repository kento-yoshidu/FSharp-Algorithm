// https://atcoder.jp/contests/abc167/tasks/abc167_a

let fn (s: string) (t: string) =
    if s = t.Substring(0, s.Length) then
        "Yes"
    else
        "No"

printfn "%s" (fn "chokudai" "chokudaiz")
//=> Yes

printfn "%s" (fn "snuke" "snekee")
//=> No

printfn "%s" (fn "a" "aa")
//=> Yes

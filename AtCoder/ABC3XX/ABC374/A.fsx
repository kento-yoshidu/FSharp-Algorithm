// https://atcoder.jp/contests/abc374/tasks/abc374_a

let fn (s: string) =
    if s.Substring(String.length s - 3, 3) = "san" then
        "Yes"
    else
        "No"

printfn "%s" (fn "takahashisan")
//=> Yes

printfn "%s" (fn "aokikun")
//=> No

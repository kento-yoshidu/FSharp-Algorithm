// https://atcoder.jp/contests/abc421/tasks/abc421_a

let fn n (s: string array) (x: int) y =
    if y = s.[x-1] then
        "Yes"
    else
        "No"

printfn "%s" (fn 3 [| "sato"; "suzuki"; "takahashi" |] 3 "takahashi")
//=> Yes

printfn "%s" (fn 3 [| "sato"; "suzuki"; "takahashi" |] 1 "aoki")
//=> No

printfn "%s" (fn 2 [| "smith"; "smith" |] 1 "smith")
//=> Yes

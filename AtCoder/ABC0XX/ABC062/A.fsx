// https://atcoder.jp/contests/abc062/tasks/abc062_a

let run x y =
    let arr = [0; 1; 0; 2; 0; 2; 0; 0; 2; 0; 2; 0]

    if arr.[x-1] = arr.[y-1] then
        "Yes"
    else
        "No"

printfn "%s" (run 1 3)
//=> Yes

printfn "%s" (run 2 4)
//=> No

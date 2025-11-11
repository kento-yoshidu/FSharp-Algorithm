// https://atcoder.jp/contests/abc422/tasks/abc422_a

let fn (s: string) =
    match s.ToCharArray() with
    | [| l; _; r |] ->
        let left = int l - int '0'
        let right = int r - int '0'
        if right = 8 then
            sprintf "%d-%d" (left + 1) 1
        else
            sprintf "%d-%d" left (right + 1)
    | _ ->
        failwithf "Unexpected input: %s" s

printfn "%s" (fn "4-2")
//=> 4-3

printfn "%s" (fn "1-8")
//=> 2-1

printfn "%s" (fn "3-3")
//=> 3-4

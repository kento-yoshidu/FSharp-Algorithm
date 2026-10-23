// https://atcoder.jp/contests/abc345/tasks/abc345_a

let fn (s: string) =
    if s.StartsWith "<"
       && s.EndsWith ">"
       && s.[1 .. s.Length - 2] |> Seq.forall (fun c -> c = '=') then
        "Yes"
    else
        "No"

printfn "%s" (fn "<====>")
//=> Yes

printfn "%s" (fn "==>")
//=> No

printfn "%s" (fn "<>>")
//=> No

// https://atcoder.jp/contests/abc384/tasks/abc384_a

let fn n c1 c2 (s: string) =
    s.ToCharArray()
    |> Array.map (fun c -> if c = c1 then c1 else c2)
    |> System.String

printfn "%s" (fn 3 'b' 'g' "abc")
//=> gbg

printfn "%s" (fn 1 's' 'h' "s")
//=> s

printfn "%s" (fn 7 'd' 'a' "atcoder")
//=> aaaadaa

printfn "%s" (fn 10 'b' 'a' "acaabcabba")
//=> aaaabaabba

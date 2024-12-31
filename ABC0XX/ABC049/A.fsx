// https://atcoder.jp/contests/abc049/tasks/abc049_a

let run c =
    if List.contains c ["a"; "i"; "u"; "e"; "o"] then
        "vowel"
    else
        "consonant"

printfn "%s" (run "a")
//=> vowel

printfn "%s" (run "z")
//=> consonant

printfn "%s" (run "s")
//=> consonant

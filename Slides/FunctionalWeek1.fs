﻿module FunctionalWeek1

open CommonLatex
open SlideDefinition
open CodeDefinitionLambda
open Interpreter

let slides =
  let zero = ("f" ==> ("x" ==> !!"x"))
  let one = ("f" ==> ("x" ==> (!!"f" >>> !!"x")))
  let two = ("f" ==> ("x" ==> (!!"f" >>> (!!"f" >>> !!"x"))))
  let succ = ("n" ==> ("f" ==> ("x" ==> (!!"f" >>> ((!!"n" >>> !!"f") >>> !!"x")))))
  let mult = ("m" ==> ("n" ==> ("f" ==> (!!"m" >>> (!!"n" >>> !!"f")))))
  let plus = ("m" ==> ("n" ==> ("f" ==> ("x" ==> (!!"m" >>> !!"f") >>> ((!!"n" >>> !!"f") >>> !!"x")))))
  [
    Section("Introduction")
    SubSection("Lecture topics")
    InferenceCodeBlock(TextSize.Tiny, zero >>> !!"s" >>> !!"0")
    InferenceCodeBlock(TextSize.Tiny, one >>> !!"s" >>> !!"0")
    InferenceCodeBlock(TextSize.Tiny, two >>> !!"s" >>> !!"0")
    InferenceCodeBlock(TextSize.Tiny, plus >>> !!"1" >>> !!"1" >>> !!"s" >>> !!"0")
    InferenceCodeBlock(TextSize.Tiny, mult >>> !!"2" >>> !!"1" >>> !!"s" >>> !!"0")
  ]

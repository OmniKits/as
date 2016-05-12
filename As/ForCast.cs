﻿using System;

public struct ForCast<TSource>
{
    private static Type TypeSource = typeof(TSource);

    public TSource Source { get; internal set; }

    public TTarget As<TTarget>()
        => Source.TypeAs<TTarget>(TypeSource);
    public TTarget AsChecked<TTarget>()
        => Source.TypeAsChecked<TTarget>(TypeSource);
    public TTarget To<TTarget>()
        => Source.TypeCast<TTarget>(TypeSource);
    public TTarget ToChecked<TTarget>()
        => Source.TypeCastChecked<TTarget>(TypeSource);
}

public static class ForCastEx
{
    public static ForCast<T> ForCast<T>(this T source)
        => new ForCast<T> { Source = source };
}

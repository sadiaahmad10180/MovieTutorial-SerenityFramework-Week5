import { registerEnum } from "@serenity-is/corelib";

export enum MovieKind {
    Film = 1,
    TvSeries = 2,
    MiniSeries = 3
}
registerEnum(MovieKind, 'MovieTutorial.MovieDB.MovieKind', 'MovieDB.MovieKind');
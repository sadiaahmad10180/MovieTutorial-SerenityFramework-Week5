import { EntityDialog } from '@serenity-is/corelib';
import { GenreForm, GenreRow, GenreService } from '../../ServerTypes/MovieDB';

export class GenreDialog extends EntityDialog<GenreRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("MovieTutorial.MovieDB.");

    protected override getFormKey() { return GenreForm.formKey; }
    protected override getRowDefinition() { return GenreRow; }
    protected override getService() { return GenreService.baseUrl; }

    protected form = new GenreForm(this.idPrefix);
}
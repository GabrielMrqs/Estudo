import { PhotoFormComponent } from './photo-form/photo-form.component';
import { PhotoListComponent } from './photo-list/photo-list.component';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PhotoComponent } from './photo/photo.component';

@NgModule({
  imports: [
    CommonModule,
    HttpClientModule
  ],
  declarations: [PhotoComponent, PhotoListComponent, PhotoFormComponent],
  exports:[PhotoComponent]
})
export class PhotosModule { }

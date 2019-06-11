import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProgramsComponent } from './programs.component';
import { SubjectsModule } from './subjects/subjects.module';

@NgModule({
  declarations: [
    ProgramsComponent
  ],
  imports: [
    CommonModule,
    SubjectsModule
  ],
  exports: [
    ProgramsComponent
  ]
})
export class ProgramsModule { }

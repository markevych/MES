import { Component, OnInit } from '@angular/core';
import { Subject } from 'src/app/models/subject.model';
import { SubjectsService } from './subjects.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-subjects',
  templateUrl: './subjects.component.html',
  styleUrls: ['./subjects.component.scss']
})
export class SubjectsComponent implements OnInit {
  subjects: Subject[];
  programId: string;
  subjectToCreate: Subject = new Subject();

  constructor(private subjectService: SubjectsService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.programId = this.route.snapshot.params['programId'];
    this.getSubjects();
  }

  getSubjects() {
    this.subjectService.getSubjects(this.programId).subscribe(res => this.subjects = res);
  }

  createSubject() {
    
  }
}

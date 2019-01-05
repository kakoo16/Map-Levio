package esprit.tn.entities;

import java.io.Serializable;
import javax.persistence.*;
import java.sql.Timestamp;


/**
 * The persistent class for the Job_Request database table.
 * 
 */
@Entity
@NamedQuery(name="Job_Request.findAll", query="SELECT j FROM Job_Request j")
public class Job_Request implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="Job_RequestId")
	private int job_RequestId;

	@Column(name="Date_Request")
	private Timestamp date_Request;

	@Column(name="Speciality")
	private String speciality;

	@Column(name="State_Type")
	private int state_Type;

	//bi-directional many-to-one association to AspNetUser
	@ManyToOne
	@JoinColumn(name="MyCandidat_Id")
	private AspNetUser aspNetUser;

	public Job_Request() {
	}

	public int getJob_RequestId() {
		return this.job_RequestId;
	}

	public void setJob_RequestId(int job_RequestId) {
		this.job_RequestId = job_RequestId;
	}

	public Timestamp getDate_Request() {
		return this.date_Request;
	}

	public void setDate_Request(Timestamp date_Request) {
		this.date_Request = date_Request;
	}

	public String getSpeciality() {
		return this.speciality;
	}

	public void setSpeciality(String speciality) {
		this.speciality = speciality;
	}

	public int getState_Type() {
		return this.state_Type;
	}

	public void setState_Type(int state_Type) {
		this.state_Type = state_Type;
	}

	public AspNetUser getAspNetUser() {
		return this.aspNetUser;
	}

	public void setAspNetUser(AspNetUser aspNetUser) {
		this.aspNetUser = aspNetUser;
	}

}
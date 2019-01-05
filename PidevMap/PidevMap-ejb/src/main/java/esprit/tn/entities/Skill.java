package esprit.tn.entities;

import java.io.Serializable;
import javax.persistence.*;
import java.util.List;


/**
 * The persistent class for the Skills database table.
 * 
 */
@Entity
@Table(name="Skills")
@NamedQuery(name="Skill.findAll", query="SELECT s FROM Skill s")
public class Skill implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="SkillId")
	private int skillId;

	private String description_Skill;

	private String name_Skill;

	private float rate_Skill;

	//bi-directional many-to-one association to Project
	@OneToMany(mappedBy="skill")
	private List<Project> projects;

	//bi-directional many-to-one association to AspNetUser
	@ManyToOne
	@JoinColumn(name="MyResource_Id")
	private AspNetUser aspNetUser;

	//bi-directional many-to-one association to RessourceN
	@ManyToOne
	@JoinColumn(name="RessourceN_RessourceId")
	private RessourceN ressourceN;

	public Skill() {
	}

	public int getSkillId() {
		return this.skillId;
	}

	public void setSkillId(int skillId) {
		this.skillId = skillId;
	}

	public String getDescription_Skill() {
		return this.description_Skill;
	}

	public void setDescription_Skill(String description_Skill) {
		this.description_Skill = description_Skill;
	}

	public String getName_Skill() {
		return this.name_Skill;
	}

	public void setName_Skill(String name_Skill) {
		this.name_Skill = name_Skill;
	}

	public float getRate_Skill() {
		return this.rate_Skill;
	}

	public void setRate_Skill(float rate_Skill) {
		this.rate_Skill = rate_Skill;
	}

	public List<Project> getProjects() {
		return this.projects;
	}

	public void setProjects(List<Project> projects) {
		this.projects = projects;
	}

	public Project addProject(Project project) {
		getProjects().add(project);
		project.setSkill(this);

		return project;
	}

	public Project removeProject(Project project) {
		getProjects().remove(project);
		project.setSkill(null);

		return project;
	}

	public AspNetUser getAspNetUser() {
		return this.aspNetUser;
	}

	public void setAspNetUser(AspNetUser aspNetUser) {
		this.aspNetUser = aspNetUser;
	}

	public RessourceN getRessourceN() {
		return this.ressourceN;
	}

	public void setRessourceN(RessourceN ressourceN) {
		this.ressourceN = ressourceN;
	}

}